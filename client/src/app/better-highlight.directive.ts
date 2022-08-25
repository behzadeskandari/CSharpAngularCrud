import { Directive, ElementRef, HostBinding, HostListener, OnInit, Renderer2 ,Input} from '@angular/core';

@Directive({
  selector: '[appBetterHighlight]'
})
export class BetterHighlightDirective implements OnInit {
  @HostBinding('style.backgroundColor') backgroundColor : any;
  @Input() defaultColor: string= 'orange';
  @Input() highlightColor: string = 'blue';
  constructor(private elemRef: ElementRef, private renderer: Renderer2) {}
 
  ngOnInit(): void {
     this.renderer.setStyle(this.elemRef.nativeElement, 'background-color', 'red');
   }


  @HostListener('mouseenter') moueOver(eventData: Event) {
    // this.renderer.setStyle(this.elemRef.nativeElement, 'background-color', 'yellow', undefined);
    this.backgroundColor = this.highlightColor;
  }

  @HostListener('mouseleave') moueLeave(eventData: Event) {
    // this.renderer.setStyle(this.elemRef.nativeElement, 'background-color', 'transparent', undefined);
    this.backgroundColor =  this.defaultColor;//'#000'
  }
}
