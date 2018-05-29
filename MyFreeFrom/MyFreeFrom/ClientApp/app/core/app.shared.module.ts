import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from '../components/app/app.component';
import { NavMenuComponent } from '../components/navmenu/navmenu.component';
import { HomeComponent } from '../components/home/home.component';
import { ResturantsComponent } from '../resturants/resturants.component';
import { ResturantsGridComponent } from '../resturants/resturant-grid.component';
import { DataService } from '../core/data.service';
import { Sorter } from './sorter';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        ResturantsComponent,
        ResturantsGridComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'resturants', component: ResturantsComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [DataService, Sorter]
})
export class AppModuleShared {
}
