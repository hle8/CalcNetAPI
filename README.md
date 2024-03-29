# CalcNetAPI

## Introduction

This is a simple calculator API which can do Addition, Subtraction, Multiplication, Division and Modulus.

## Usage

```
http://<server-ip>:<port>/calculator/<operator-name>?firstNum=<your-first-number>&secondNum=<your-second-number>
```

Where:

`<server-ip>` IP address of server

`<port>` Port number of server

`<operator-name>` There are 5 operators: Add, Subtract, Multipy, Divide and Modulo

`<your-first-number>` Enter your first number

`<your-second-number>` Enter your second number

## Components

- [Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/)

## What I have done

 | Task                                                                                     | Status             |
 | ---------------------------------------------------------------------------------------- | ------------------ |
 | Create an ASP.Net Core Web API                                                           | :white_check_mark: |
 | Clean up the project by deleting the WeatherForecast class and WeatherForecastController | :white_check_mark: |
 | Create a new api controller called calculator                                            | :white_check_mark: |
 | Create a method named Add accepting 2 decimal parameters                                 | :white_check_mark: |
 | Check returning sum of the two parameters                                                | :white_check_mark: |
 | Create a method named Subtract accepting 2 decimal parameters                            | :white_check_mark: |
 | Check returning difference of the two parameters                                         | :white_check_mark: |
 | Create a method named Multiply accepting 2 decimal parameters                            | :white_check_mark: |
 | Check returning product of the two parameters                                            | :white_check_mark: |
 | Create a method named Divide accepting 2 decimal parameters                              | :white_check_mark: |
 | Check returning quotient of the two parameters                                           | :white_check_mark: |
 | Create a method named Modulo accepting 2 decimal parameters                              | :white_check_mark: |
 | Check returning remainder of the two parameters                                          | :white_check_mark: |
 | Create a class library and move the logic from API controller into it                    | :white_check_mark: |
 | Create unit tests for the class library                                                  | :white_check_mark: |

## Future intentions

:sparkles: Add more functions to the API (unit converter, etc.).

:sparkles: Add hardware acceleration feature using FPGA.
