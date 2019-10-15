# microservices-example
There are three services. Calculator, Summation and Multiplication. Consumer cannot consume Summation and Multiplication services. it has to go through Calculator service. Based on input from client, Calculator service will call either Summation or multiplication service.

MultiplicationService: Return square of input number. 

SummationService: Return number * 2 of input number.

CalculatorService: Responsible to call either MultiplicationService or SummationService.

Consumer: Will call to CalculatorService only.


