import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { IResturant, IReview, IDietOption } from '../shared/interfaces';

@Injectable()
export class DataService {

    baseUrl: string = '/api/resturants';

    constructor(private http: Http) {

    }

    getResturants(): Observable<IResturant[]> {
        return this.http.get(this.baseUrl)
            .map((res: Response) => {
                let resturants = res.json();
                return resturants;
            })
    }


}