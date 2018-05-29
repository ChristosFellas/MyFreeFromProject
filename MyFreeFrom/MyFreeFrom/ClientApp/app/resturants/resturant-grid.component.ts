import { Component, Input, OnInit, ChangeDetectionStrategy } from '@angular/core';

import { IResturant } from '../shared/interfaces';
import { Sorter } from '../core/sorter';

@Component({
    selector: 'resturants-grid',
    templateUrl: './resturants-grid.component.html',
    changeDetection: ChangeDetectionStrategy.OnPush
})
export class ResturantsGridComponent implements OnInit {

    @Input() resturants: IResturant[] = [];

    constructor(private sorter: Sorter) { }

    ngOnInit() {

    }

    sort(prop: string) {
        this.sorter.sort(this.resturants, prop);
    }
}
