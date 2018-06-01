import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

import { ResturantDataService } from '../core/resturantData.service';
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

    id: any;


    operationText: string = 'Insert';
    errorMessage: string = '';

    constructor(private router: Router,
        private route: ActivatedRoute,
        private resturantDataService: ResturantDataService) { }

    ngOnInit() {
        this.id = this.route.snapshot.params['id'];
        if (this.id !== '0') {
            this.operationText = 'Update';
            this.getResturant(this.id);
        }
    }

    getResturant(id: string) {
        this.resturantDataService.getResturant(id)
            .subscribe((resturant: IResturant) => {
                this.resturant = resturant;
            }),
            (err: any) => console.log(err);
    }

    submit() {
        if (this.resturant.id) {

        } else {
            this.resturantDataService.insertResturant(this.resturant)
                .subscribe((resturant: IResturant) => {
                    this.router.navigate(['/resturants']);
                });
        }
    }

    delete(event: Event) {
        event.preventDefault();
        this.resturantDataService.deleteResturant(this.id)
            .subscribe((status: boolean) => {
                    this.router.navigate(['/resturants']);
            });
    }

    cancel(event: Event) {
        event.preventDefault();
        this.router.navigate(['/resturants']);
    }
}