import { NgModule, ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ReasonComponent } from './components/reason/reason.component';

const routes: Routes = [
  { path: '', component: ReasonComponent},
  { path: 'reasons', component: ReasonComponent}

];

export const routing: ModuleWithProviders = RouterModule.forRoot(routes, {
  useHash: true
});
