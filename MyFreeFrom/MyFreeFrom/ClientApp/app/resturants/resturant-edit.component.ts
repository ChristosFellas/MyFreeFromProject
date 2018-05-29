import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { DataService } from '../core/data.service';
import { IResturant, IDietOption } from '../shared/interfaces';

@Component({
    selector: 'resturant-edit',
    templateUrl: './resturant-edit.component.html'
})
export class ResturantEditComponent implements OnInit {
    dietOptions: IDietOption[] = [];

    resturant: IResturant = {
        name: '',
        description: '',
        latitude: '',
        longitude: '',
        address: '',
        address2: '',
        city: '',
        county: '',
        websiteUrl: '',
        phoneNumber: '',
        dietOptions: this.dietOptions
    };


    operationText: string = 'Insert';
    errorMessage: string = '';

    constructor(private router: Router,
        private route: ActivatedRoute,
        private dataService: DataService) { }

    ngOnInit() {
        let id = this.route.snapshot.params['id'];
        if (id !== '0') {
            this.operationText = 'Update';
            this.getResturant(id);
        }
    }

    getResturant(id: string) {
        this.dataService.getResturant(id)
            .subscribe((resturant: IResturant) => {
                this.resturant = resturant;
            }),
            (err: any) => console.log(err);
    }

    submit() {
        if (this.resturant.id) {

        } else {
            this.dataService.insertResturant(this.resturant)
                .subscribe((resturant: IResturant) => {
                        this.router.navigate(['/resturants']);
                });
        }
    }

    cancel(event: Event) {
        event.preventDefault();
        this.router.navigate(['/resturants']);
    }
}