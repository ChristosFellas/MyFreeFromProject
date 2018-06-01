import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { IResturant, IReview, IDietOption } from '../shared/interfaces';

@Injectable()
export class ReviewDataService {
    baseUrl: string = '/api/resturants';

    constructor(private http: Http) { }

    getReviewsForResturant(id: string): Observable<IReview[]> {
        return this.http.get(this.baseUrl + '/' + id + '/' + 'reviews')
            .map((res: Response) => {
                let reviews = res.json();
                return reviews;
            });
    }



}