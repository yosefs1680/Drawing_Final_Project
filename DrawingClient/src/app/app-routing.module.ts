import { CreateDocComponent } from './components/create-doc/create-doc.component';
import { LoginComponent } from './components/login/login.component';
import { DocsListComponent } from './components/docs-list/docs-list.component';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule,  } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './components/register/register.component';
import { DrawingComponent } from './components/drawing/drawing.component';

const routes: Routes = [
  { path: '', component: RegisterComponent },
  { path: 'my-documents', component: DocsListComponent },
  { path: 'login', component: LoginComponent },
  { path: 'drawing/:docId', component: DrawingComponent },
  { path: 'create-doc', component: CreateDocComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes),
    FormsModule, ReactiveFormsModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
