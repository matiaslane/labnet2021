import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonSubmitComponent } from './button-submit/button-submit.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FooterComponent } from './footer/footer.component';


@NgModule({
  declarations: [
    ButtonSubmitComponent,
    NavbarComponent,
    FooterComponent,
  ],
  exports: [
    ButtonSubmitComponent,
    NavbarComponent,
    FooterComponent
  ],
  imports: [
    CommonModule,
  ]
})
export class ControlsModule { }
