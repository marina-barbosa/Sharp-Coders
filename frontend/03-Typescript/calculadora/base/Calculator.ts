export interface Calculator{
    sum(first:number,last:number): number;
    subtract(first:number,last:number): number;
    multiply(first:number,last:number): number;
    divide(first:number,last:number): number;
    showValue():void;
}