import { HttpClient, HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule,  } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './components/register/register.component';
import { DocsListComponent } from './components/docs-list/docs-list.component'
import { LoginCommService } from './Services/commServicesAbstract/login-comm.service';
import { RegisterCommService } from './Services/commServicesAbstract/register-comm.service';
import { DocsCommService } from './Services/commServicesAbstract/docs-comm.service';
import { RemoteDocsService } from './Services/commServicesImpl/remote-docs.service';
import { LoginComponent } from './components/login/login.component';
import { RemoteLoginService } from './Services/commServicesImpl/remote-login.service';
import { RemoteRegisterService } from './Services/commServicesImpl/remote-register.service';
import { DrawingComponent } from './components/drawing/drawing.component';
import { RemoteMarkerService } from './Services/commServicesImpl/remote-marker.service';
import { MarkerCommService } from './Services/commServicesAbstract/marker-comm.service';
import { CreateDocComponent } from './components/create-doc/create-doc.component';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    DocsListComponent,
    DrawingComponent,
    CreateDocComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,    
  ],
  providers: [
    { provide: LoginCommService, useClass: RemoteLoginService },
    { provide: RegisterCommService, useClass: RemoteRegisterService },
    { provide: DocsCommService, useClass: RemoteDocsService },
    { provide: MarkerCommService, useClass: RemoteMarkerService },
    
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
