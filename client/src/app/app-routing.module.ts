import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateComponent } from './supplier/create/create.component';
import { EditComponent } from './supplier/edit/edit.component';
import { HomeComponent } from './supplier/home/home.component';

const routes: Routes = [
  {
    path: 'supplier/home',
    component: HomeComponent,
    pathMatch: 'full'
  },
  {
    path: 'supplier/create',
    component: CreateComponent,
    pathMatch: 'full'
  },
  {
    path: 'supplier/edit/:id',
    component: EditComponent
  },
  {
    path: '**',
    component: HomeComponent,

  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
