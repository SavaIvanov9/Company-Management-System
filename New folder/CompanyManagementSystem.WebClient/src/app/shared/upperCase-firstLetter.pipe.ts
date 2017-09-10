import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'upperCaseFirstLetter'
})
export class UpperCaseFirstLetterPipe implements PipeTransform {

  transform(value: any, args?: any): any {
    if (value === null) {
      return 'no value is given';
    }
    return value.charAt(0).toUpperCase() + value.slice(1);
  }
}
