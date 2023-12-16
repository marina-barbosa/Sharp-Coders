import { Calculator } from "./Calculator";

type Operation='+'|'-'|'x'|'/';

export class CalcExtension implements Calculator {
    
    private value:number;

    cosntructor() {
        this.value = 0;
    }

    private calcLogic(first:number,operation:Operation,last:number):number{
        switch (operation) {
            case '+':
                return this.sum(first,last);                
            case '-':                
                return this.subtract(first,last);
            case 'x':                
                return this.multiply(first,last);
            case '/':                
                return this.divide(first,last);        
            default:
                break;
        }
        return 0;
    }

    public calculate(first:number,operation:Operation,last:number){
      let result=this.calcLogic(first,operation,last);
      this.value=result;
    }

    sum(first: number, last: number): number {
        return first + last;
    }
    subtract(first: number, last: number): number {
        return first - last;;
    }
    multiply(first: number, last: number): number {
        return first * last;
    }
    divide(first: number, last: number): number {
        return first / last;
    }
    showValue(): void {
        console.log(this.value)
    }
    
}