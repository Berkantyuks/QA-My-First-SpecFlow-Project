﻿Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Smoke @Calc
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should "PASS"

@DataDrivenTesting
Scenario: Working with tables
	Given Input following numbers for the calculator
		| Numbers |
		| 50      |
		| 70      |
	When the two numbers are added
	Then See result and details
		| Result | Details |
		| 120    | Plus    |
	Then the result should "PASS"