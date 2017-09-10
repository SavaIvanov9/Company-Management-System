import { Directive, ElementRef } from '@angular/core';

@Directive({
  selector: '[appStrongItem]'
})
export class StrongItemDirective {

  constructor(private elementRef: ElementRef) {
    elementRef.nativeElement.style = 'font-weight:bold';
  }
}
