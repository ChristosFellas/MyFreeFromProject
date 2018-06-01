import { Component, Input, OnInit, ChangeDetectionStrategy, Class } from '@angular/core';

import { IReview } from '../shared/interfaces';
import { Sorter } from '../core/sorter';

@Component({
    selector: 'reviews-grid',
    templateUrl: './reviews-grid.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ReviewsGridComponent implements OnInit {

    @Input() reviews: IReview[] = [];

    constructor(private sorter: Sorter) { }

    ngOnInit() { }

    sort(prop: string) {
        this.sorter.sort(this.reviews, prop);
    }

}