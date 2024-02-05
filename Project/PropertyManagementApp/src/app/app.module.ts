import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PropertyListComponent } from './property-list/property-list.component';
import { PropertyCreateComponent } from './property-create/property-create.component';
import { PropertyEditComponent } from './property-edit/property-edit.component';
import { TableModule } from 'primeng/table';
import { PropertyService } from './property.service';
import { ButtonModule } from 'primeng/button';
import { FormsModule } from '@angular/forms';
import { InputTextModule } from 'primeng/inputtext';
import { TabMenuModule } from 'primeng/tabmenu';
import { TabViewModule } from 'primeng/tabview';
import { HomeComponent } from './home/home.component';
import { EnquireComponent } from './enquire/enquire.component';

@NgModule({
  declarations: [
    AppComponent,
    PropertyListComponent,
    PropertyCreateComponent,
    PropertyEditComponent,
    HomeComponent,
    EnquireComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    TableModule,
    ButtonModule,
    FormsModule,
    InputTextModule,
    TabMenuModule,
    TabViewModule
  ],
  providers: [PropertyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
