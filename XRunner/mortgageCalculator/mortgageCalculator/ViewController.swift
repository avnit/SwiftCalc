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
    
    func calculate( loanAmount: Double, term: Double, interestRate: Double ) ->Double
    {
        return ((loanAmount * term * interestRate) / 100) + loanAmount
    }
    func  mtgViewController() -> UIView  {
        let root = UIView(frame: CGRect(x:0, y:0 , width:640 , height:1136))
        root.backgroundColor = UIColor.whiteColor()
        
        //adding label this is mtg calculator
        var label = UILabel(frame: CGRectMake(0, 0, 120,120))
        label.center = CGPointMake(100, 100)
        label.textAlignment = NSTextAlignment.Center
        label.text = "Avnit's Mortage calculator"
        root.addSubview(label)
        
       // <#x: CGFloat#>
        var input_label = UILabel(frame: CGRectMake(10,10,100,100))
        label.center = CGPointMake(200,200)
        label.textAlignment = NSTextAlignment.Justified
        label.text = "Initial Amount"
        root.addSubview(input_label)
        
       // row.addSubView(view)
       return root
    }
}

var loanAmount: Double = 8000000.00
var term: Double = 1.0
var interestRate: Double = 9.0

var a = calculator()
var result: Double = a.calculate(loanAmount, term: term, interestRate: interestRate)








class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
        self.view = a.mtgViewController()
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

