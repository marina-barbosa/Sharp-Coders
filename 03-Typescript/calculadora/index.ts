import { CalcExtension } from "./base/CalcExtension";

let calc=new CalcExtension();

calc.calculate(3,'+',7);
calc.showValue();

calc.calculate(3,'-',7);
calc.showValue();

calc.calculate(3,'x',7);
calc.showValue();

calc.calculate(3,'/',7);
calc.showValue();
