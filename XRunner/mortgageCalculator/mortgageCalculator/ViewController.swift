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
        root.backgroundColor = UIColor.darkGrayColor()
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

