﻿import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { IResturant, IReview, IDietOption } from '../shared/interfaces';

@Injectable()
export class ResturantDataService {

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

    getResturant(id: string): Observable<IResturant> {
        return this.http.get(this.baseUrl + '/' + id)
            .map((res: Response) => res.json());
    }

    insertResturant(resturant: IResturant): Observable<IResturant> {
        return this.http.post(this.baseUrl, resturant)
            .map((res: Response) => {
                const data = res.json();
                console.log('insertCustomer status: ' + data.status);
                return data.resturant;
            });
    }

    deleteResturant(id: string): Observable<boolean> {
        return this.http.delete(this.baseUrl + '/' + id)
            .map((res: Response) => res.json());
    }
}