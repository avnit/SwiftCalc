//
//  ViewController.swift
//  Calculator
//
//  Created by Avnit Bambah on 5/13/15.
//  Copyright (c) 2015 Avnit Bambah. All rights reserved.
//

import UIKit

/*---
### Returning to a struct with some conveniences (Z2S01)
*/

/// A calculation that holds a left term, a right term, and an operation
struct Calc<T> {
    var lt: () -> T
    var op: (T, T) -> T
    var rt: () -> T
    
    init(lt: () -> T, op: (T, T) -> T, rt: () -> T) {
        self.lt = lt
        self.op = op
        self.rt = rt
    }
    
    init(const: T) {
        self.init(lt: { const }, op: { lt, rt in lt }, rt: { const })
    }
    
    var calculate: (() -> T) {
        return { self.op(self.lt(), self.rt()) }
    }
    
    /// Appends the given operation and constant value to the calculation
    ///
    /// :param: op the operation to append to the calculation
    /// :param: the constant value to use as the operand
    mutating func push(op: (T, T)->T, value: T) {
        self = Calc(lt: self.calculate, op: op, rt: { value })
    }
}

/*---
### Calculator digit enumeration
*/

/// A digit from 0-9
enum Digit: UInt {
    case D0 = 0, D1, D2, D3, D4, D5, D6, D7, D8, D9
}

/*---
### Making a Number Entry component (Z2S02)
*/

enum Sign: Double {
    case Positive = 1
    case Negative = -1
}

/// A numeric entry area that handles partially-entered numbers such as "-0."
struct NumberEntry {
    var number: UInt = 0
    var exponent: UInt = 0
    var sign: Sign = .Positive
    
    /// The currently entered number as a Double
    var decimalValue: Double {
        get {
            var num = Double(number)
            
            for _ in 1..<max(1, exponent) {
                num /= 10
            }
            
            num *= sign.rawValue
            return num
        }
    }
    
    /// Tack on the given digit to the number, incrementing the exponent if it is a fraction
    ///
    /// :param: digit the digit from 0-9 to append to the string
    mutating func appendDigit(digit: Digit) {
        number *= 10
        number += digit.rawValue
        if exponent > 0 {
            exponent++
        }
    }
    
    mutating func reset(sign: Sign = .Positive) {
        self = NumberEntry()
        self.sign = sign
    }
}

/*---
### Calculator key type enumeration (Z2S03)
*/

/// A calculator component
enum CalcPartType {
    case Display, Plus, Minus, Divide, Multiply, Equal, Decimal, Clear, SwapSign, Percent, Num(Digit)
}


/*---
### Making a calculator (Z2S04)
*/

typealias CalcOp = (Double, Double)->Double

enum CalcMode {
    case Entry
    case Operation(CalcOp)
}

struct Calculator {
    var curop: CalcOp = (+)
    var mode: CalcMode = .Operation(+)
    var entry: NumberEntry = NumberEntry()
    var calc: Calc<Double> = Calc(const: 0)
    
    mutating func push(op: CalcOp, value: Double) {
        toMode(.Operation(+))
        calc.push(op, value: value)
    }
    
    mutating func toMode(newmode: CalcMode) -> Bool {
        switch (mode, newmode) {
        case (.Entry, .Operation(let newop)):
            calc.push(curop, value: entry.decimalValue)
            mode = .Operation(newop)
            entry.reset()
            curop = newop
            return true
        case (.Operation, .Entry):
            entry.reset()
            mode = .Entry
            return true
        case (.Entry, .Entry):
            mode = newmode
            return false
        case (.Operation, .Operation(let newop)):
            mode = newmode
            curop = newop
            return false
        }
    }
    
    mutating func press(type: CalcPartType) {
        switch type {
        case .Display: break
        case .Num(let digit):
            toMode(.Entry)
            entry.appendDigit(digit)
        case .Decimal:
            toMode(.Entry)
            if entry.exponent == 0 {
                entry.exponent = 1
            }
        case .Minus: toMode(.Operation(-))
        case .Plus: toMode(.Operation(+))
        case .Divide: toMode(.Operation(/))
        case .Multiply: toMode(.Operation(*))
        case .Clear: push(*, value: 0.0)
        case .SwapSign: push(*, value: -1.0)
        case .Percent: push(*, value: 0.01)
        case .Equal: push(+, value: 0)
        }
    }
}

 var calculator = Calculator()


/*---
### Part Labels
*/

extension CalcPartType {
    var label: String {
        switch self {
        case Display: return ""
        case Plus: return "+"
        case Minus: return "-"
        case Divide: return "÷"
        case Multiply: return "×"
        case Equal: return "="
        case Decimal: return "."
        case Clear: return "C"
        case SwapSign: return "±"
        case Percent: return "%"
        case Num(let digit): return toString(digit.rawValue)
        }
    }
}

/*---
### Display Output Formatting (Z2S05)
*/

import Foundation

func displayString(calc: Calculator) -> String {
    switch (calc.mode, calc.entry.exponent) {
    case (.Entry, 0):
        return String(format: "%g", calc.entry.decimalValue)
    case (.Entry, let exp):
        return dropLast(String(format: "%.\(exp)f", calc.entry.decimalValue))
    case (.Operation, _):
        return String(format: "%g", calc.calc.calculate())
    }
}


func xpectcalc(val: String, types: [CalcPartType]) -> String { // NOSLIDE
    for type in types { // NOSLIDE
        calculator.press(type) // NOSLIDE
    } // NOSLIDE
    return val == displayString(calculator) ? "Success" : "Fail: \(val) vs. \(displayString(calculator))" // NOSLIDE
} // NOSLIDE


/*---
### Making a calculator key (Z2S06)
*/

import UIKit

class CalcPartView: UILabel {
    let handler: () -> Void
    
    required init(coder aDecoder: NSCoder) {
        fatalError("init(coder:) has not been implemented")
    }
    
    init(type: CalcPartType, handler: () -> Void) {
        self.handler = handler
        
        super.init(frame: CGRect(x: 0, y: 0, width: 200, height: 200))
        
        self.textAlignment = .Center
        self.layer.borderWidth = 0.5
        self.font = UIFont.systemFontOfSize(45)
        self.adjustsFontSizeToFitWidth = true
        self.userInteractionEnabled = true
        
        self.text = type.label
        self.setTranslatesAutoresizingMaskIntoConstraints(false)
        
        
        switch type {
        case .Display:
            self.textColor = UIColor.blackColor()
            self.backgroundColor = UIColor.whiteColor()
            self.textAlignment = .Right
        case .Plus, .Minus , .Multiply , .Divide , .Equal:
            self.textColor = UIColor.whiteColor()
            self.backgroundColor = UIColor.orangeColor()
        case .Num, .Decimal:
            self.backgroundColor = UIColor(white: 0.84, alpha: 1.0 )
            self.textColor = UIColor.blackColor()
            
        case .Clear ,.SwapSign ,.Percent:
            self.textColor = UIColor.blackColor()
            self.backgroundColor = UIColor.whiteColor()
            
        }
        
    }
    
    override func touchesBegan(touches: Set<NSObject>, withEvent event: UIEvent) {
        self.layer.borderWidth = 2.0
        handler()
    }
    
    override func touchesEnded(touches: Set<NSObject>, withEvent event: UIEvent) {
        self.layer.borderWidth = 0.5
    }
}

/*---
### Laying out the calculator view (Z2S08)
*/


func makeCalcView(bounds: CGRect) -> UIView {
    let parts: [[CalcPartType]] = [
        [.Display],
        [.Clear, .SwapSign, .Percent, .Divide],
        [.Num(.D7), .Num(.D8), .Num(.D9), .Multiply],
        [.Num(.D4), .Num(.D5), .Num(.D6), .Minus],
        [.Num(.D1), .Num(.D2), .Num(.D3), .Plus],
        [.Num(.D0), .Decimal, .Equal]
    ]
    
    let root = UIView(frame: bounds)
    root.backgroundColor = UIColor.blackColor()
    
    var calculator = Calculator()
    
    var display: CalcPartView?
    
    let grid: [[CalcPartView]] = parts.map { partsRow in
        return partsRow.map { part in
            let partView = CalcPartView(type: part) {
                calculator.press(part)
                display?.text = displayString(calculator)
            }
            root.addSubview(partView)
            return partView
        }
    }
    
    func pin(view1: UIView, attr1: NSLayoutAttribute, view2: UIView, attr2: NSLayoutAttribute) {
        let lc = NSLayoutConstraint(item: view1, attribute: attr1, relatedBy: .Equal, toItem: view2, attribute: attr2, multiplier: 1.0, constant: 0.0)
        root.addConstraint(lc)
    }
    
    
    for (row, views) in enumerate(grid) {
        for (col, view) in enumerate(views) {
            pin(view, .Height, grid[0][0], .Height)
            
            switch (row, col) {
            case (0, _):
                pin(view, .Top, root, .Top)
            case (grid.count-1, _):
                pin(view, .Bottom, root, .Bottom)
                fallthrough
            case (_, _):
                pin(view, .Top, grid[row-1][0], .Bottom)
            }
            
            switch (row, col) {
            case (0, 0):
                pin(view, .Left, root, .Left)
                pin(view, .Right, root, .Right)
            case (_, 0):
                pin(view, .Left, root, .Left)
            case (_, views.count-1):
                pin(view, .Right, root, .Right)
                fallthrough
            case (_, _):
                pin(view, .Left, grid[row][col-1], .Right)
                pin(view, .Width, grid[1][0], .Width)
            }
        }
    }
    
    root.layoutIfNeeded()
    
    return root
}


let calcView = makeCalcView(CGRect(x:0, y:0, width: 500, height: 500))



class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        
        self.view = calcView
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

