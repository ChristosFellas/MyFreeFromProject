import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../core/data.service';
import { Sorter } from '../core/sorter';
import { IResturant, IDietOption, IReview } from '../shared/interfaces';

@Component({
    moduleId: 'module.id',
    selector: 'resturants',
    templateUrl: './resturants.component.html'
})

export class ResturantsComponent implements OnInit {


    resturants: IResturant[] = [];
    filteredResturants: IResturant[] = [];


    constructor(private dataService: DataService, private sorter: Sorter) {
    }


    ngOnInit() {
        this.getResturants();
    }


    getResturants() {
        this.dataService.getResturants()
            .subscribe((resturants: IResturant[]) => {
                this.resturants = this.filteredResturants = resturants;
            },
                (err: any) => console.log(err),
                () => console.log('getResturants() was called.'));
    }

    sort(prop: string) {
        this.sorter.sort(this.resturants, prop);
    }
}