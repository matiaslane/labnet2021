import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-button-submit',
  templateUrl: './button-submit.component.html'
})
export class ButtonSubmitComponent implements OnInit {

  @Input() public isLoadingFlag: boolean | undefined;
  @Input() public buttonText: string | undefined;
  @Input() public class: string | undefined;

  ngOnInit(): void {
  }

}
