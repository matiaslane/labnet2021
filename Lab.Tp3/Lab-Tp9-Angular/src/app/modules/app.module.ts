import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app/app.component';
import { CategoriesModule } from './categories/categories.module';
import { ControlsModule } from './controls/controls.module';
import { RoutingModule } from './routing/routing.module';
import { ShippersModule } from './shippers/shippers.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    ControlsModule,
    RoutingModule,
    CategoriesModule,
    ShippersModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
