import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriesListComponent } from '../categories/categories-list/categories-list.component';
import { ShippersFormComponent } from '../shippers/shippers-form/shippers-form.component';
import { ShippersListComponent } from '../shippers/shippers-list/shippers-list.component';

const routes: Routes = [{
  component: CategoriesListComponent,
  path: 'categories'
},
{
  component: ShippersListComponent,
  path: 'shippers'
},
{
  component: ShippersFormComponent,
  path: 'shippers/new'
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class RoutingModule { }
