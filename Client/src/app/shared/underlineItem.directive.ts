import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appUnderlineItem]'
})
export class UnderlineItemDirective {

  constructor(private elementRef: ElementRef) { }

  @HostListener('mouseenter') onMouseEnter() {
    this.underlineOn();
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.underlineOff();
  }

  private underlineOn() {
    this.elementRef.nativeElement.style = 'text-decoration: underline';
  }

  private underlineOff() {
    this.elementRef.nativeElement.style = 'text-decoration: none';
  }
}
