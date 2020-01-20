import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { routing } from './app.routing.module';
//services
import { ReasonsServiceService } from './services/reasons-service.service';
//components
import { AppComponent } from './app.component';
import { ReasonComponent } from './components/reason/reason.component';
import { ReasondescriptionComponent } from './components/reasondescription/reasondescription.component';


@NgModule({
  declarations: [
    AppComponent,
    ReasonComponent,
    ReasondescriptionComponent
  ],
  imports: [
    routing,
    BrowserModule,
    HttpClientModule
  ],
  providers: [ReasonsServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
