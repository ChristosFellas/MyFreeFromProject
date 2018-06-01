import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { ReviewDataService } from '../core/reviewDataService';
import { Sorter } from '../core/sorter';
import { IResturant, IDietOption, IReview } from '../shared/interfaces';

@Component({
    moduleId: 'module.id',
    selector: 'reviews',
    templateUrl: './reviews.component.html'
})

export class ReviewsComponent implements OnInit {

    reviews: IReview[] = [];
    id: any;

    constructor(private route: ActivatedRoute,
                private router: Router,
                private reviewDataService: ReviewDataService) {
    }

    ngOnInit() {
        this.id = this.route.snapshot.params['id'];
        if (this.id !== '0') {
            this.getReviews(this.id);
        }
    }
        getReviews(id: string){
            this.reviewDataService.getReviewsForResturant(this.id)
                .subscribe((reviews: IReview[]) => {
                    this.reviews = reviews;
                });
        }
}