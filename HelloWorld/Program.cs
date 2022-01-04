// See https://aka.ms/new-console-template for more information
using HelloWorld;
using HelloWorld.UC9;
using HelloWorld.UCLastFinalSolution;

//Console.WriteLine("Hello, World!");
//UC1_EmployeeAttendance.GetAttendance();
//UC2_EmpWage.EmpWage();
//UC3_PartTimeEmpWage.PartTimeEmpWage();
//UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();

//UC1_EmployeeAttendance.GetAttendance();
////UC2_EmpWage.EmpWage();

//#region UC9
//EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
//EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
//dMart.computeEmpWage();
//Console.WriteLine(dMart.toString());
//reliance.computeEmpWage();
//Console.WriteLine(reliance.toString());
//#endregion  UC9Ending

//#region UC10
//EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
//empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
//empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
//empWageBuilder.computeEmpWage();
//#endregion

#region FinalSolution
EmpWageBuilder empWageBuild = new EmpWageBuilder();
empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuild.computeEmpWage();
#endregion

Console.ReadKey();
