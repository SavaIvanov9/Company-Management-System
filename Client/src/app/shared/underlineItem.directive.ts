import { Directive, ElementRef, HostListener, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appUnderlineItem]'
})
export class UnderlineItemDirective {

  constructor(private elementRef: ElementRef, private rend: Renderer2) { }

  @HostListener('mouseenter') onMouseEnter() {
    this.underlineOn();
  }

  @HostListener('mouseleave') onMouseLeave() {
    this.underlineOff();
  }

  private underlineOn() {
    this.rend.setStyle(this.elementRef.nativeElement, 'text-decoration', 'underline');
  }

  private underlineOff() {
    this.elementRef.nativeElement.style = 'text-decoration: none';
  }
}
