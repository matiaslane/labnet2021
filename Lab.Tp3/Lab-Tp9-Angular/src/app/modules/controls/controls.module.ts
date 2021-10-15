import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonSubmitComponent } from './button-submit/button-submit.component';
import { NavbarComponent } from './navbar/navbar.component';


@NgModule({
  declarations: [
    ButtonSubmitComponent,
    NavbarComponent,
  ],
  exports: [
    ButtonSubmitComponent,
    NavbarComponent,
  ],
  imports: [
    CommonModule,
  ]
})
export class ControlsModule { }
