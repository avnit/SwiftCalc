//
//  ViewController.swift
//  mortgageCalculator
//
//  Created by Avnit Bambah on 5/17/15.
//  Copyright (c) 2015 Avnit Bambah. All rights reserved.
//

import UIKit




var str = "Hello, playground"

class calculator
{
    /*  let loanAmount: Double
    let term: Double
    let interestRate: Double
    
    func init (loanAmount: Double , term: Double , interestRate: Double)
    {
    self.loanAmount = loanAmount
    self.term = term
    self.interestRate = interestRate
    println("We are in Init")
    }
    */
    
    func buttonAction(sender:UIButton!)
    {
        println("Button tapped")
    }
    
    func calculate( loanAmount: Double, term: Double, interestRate: Double ) ->Double
    {
        let output_fn: Double = ((loanAmount * term * interestRate) / 100 ) + loanAmount
        println("Output is \(output_fn)")
        return output_fn
    }
    func  mtgViewController() -> UIView  {
        let root = UIView(frame: CGRect(x:0, y:0 , width:640 , height:1136))
        root.backgroundColor = UIColor.whiteColor()
        
        //adding label this is mtg calculator
        var label = UILabel(frame: CGRectMake(100, 50, 200,30))
        //  label.center = CGPointMake(100, 100)
        label.textAlignment = NSTextAlignment.Center
        label.text = "Avnit's Mortage calculator"
        root.addSubview(label)
        
        // <#x: CGFloat#>
        var input_label = UILabel(frame: CGRectMake(50,100,100,30))
        //  label.center = CGPointMake(200,200)
        input_label.textAlignment = NSTextAlignment.Justified
        input_label.text = "Initial Amount"
        root.addSubview(input_label)
        
        var txtField: UITextField = UITextField()
        txtField.frame = CGRectMake(150, 100, 100, 30)
        txtField.backgroundColor = UIColor.grayColor()
        root.addSubview(txtField)
        
        
        
        let button   = UIButton.buttonWithType(UIButtonType.System) as! UIButton
        button.frame = CGRectMake(100, 200, 100, 30)
        button.backgroundColor = UIColor.greenColor()
        button.setTitle("Calculate", forState: UIControlState.Normal)
        button.addTarget(self, action: "buttonAction:", forControlEvents: UIControlEvents.TouchUpInside)
        
        root.addSubview(button)
        
        
        
        
        // row.addSubView(view)
        return root
    }
}

var loanAmount: Double = 8000000.00
var term: Double = 1.0
var interestRate: Double = 9.0


//var result: Double = a.calculate(loanAmount, term: term, interestRate: interestRate)


extension String {
    var floatValue: Float {
        return (self as NSString).floatValue
    }
    var doubleValue: Double {
        return (self as NSString).doubleValue
    }
}

extension Double {
    var stringValue: String {
        return ((self as NSNumber).stringValue as String)
    }
}





class ViewController: UIViewController {
    
    @IBOutlet weak var inputAmount: UITextField!
    
    @IBOutlet weak var inputterm: UITextField!
    
    @IBOutlet weak var inputInterestRate: UITextField!
    
    
    @IBOutlet weak var OutputPayments: UITextField!
    
    func calculate( loanAmount: Double, term: Double, interestRate: Double ) ->Double
    {
        //let output_fn: Double = ((loanAmount * term * interestRate) / 100 ) + loanAmount
        
        let output_fn: Double = loanAmount * (pow((1.0 + (interestRate/100)) , term ))
        println("Output is \(output_fn)")
        return output_fn/(term * 12)
    }
    
    @IBAction func ButtonCalculate(sender: AnyObject) {
     //   var a: calculator = calculator()
        var text_output: Double = calculate(inputAmount.text.doubleValue , term: inputterm.text.doubleValue, interestRate: inputInterestRate.text.doubleValue)
        OutputPayments.text = text_output.stringValue
    }
    
    
}

