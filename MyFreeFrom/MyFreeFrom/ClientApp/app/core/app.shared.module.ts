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
import { ResturantEditComponent } from '../resturants/resturant-edit.component';
import { ReviewsComponent } from '../reviews/reviews-component';
import { ReviewsGridComponent } from '../reviews/reviews-grid.component';
import { ResturantDataService } from '../core/resturantData.service';
import { ReviewDataService } from '../core/reviewDataService';
import { Sorter } from './sorter';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        ResturantsComponent,
        ResturantsGridComponent,
        ResturantEditComponent,
        ReviewsComponent,
        ReviewsGridComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'resturants', component: ResturantsComponent },
            { path: 'resturants/:id', component: ResturantEditComponent },
            { path: 'reviews/:id', component: ReviewsComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [ResturantDataService, ReviewDataService, Sorter]
})
export class AppModuleShared {
}
