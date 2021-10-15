import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersListComponent } from './shippers-list/shippers-list.component';
import { ShippersFormComponent } from './shippers-form/shippers-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ControlsModule } from '../controls/controls.module';
import { NgxBootstrapConfirmModule } from 'ngx-bootstrap-confirm';


@NgModule({
  declarations: [
    ShippersListComponent,
    ShippersFormComponent,
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    ControlsModule,
    NgxBootstrapConfirmModule
  ]
})
export class ShippersModule { }
