import { ModuleWithProviders } from '@angular/core';


export interface IResturant {
    id?: string;
    name: string;
    description: string;
    latitude: string;
    longitude: string;
    address: string;
    address2: string;
    city: string;
    county: string;
    phoneNumber: string;
    websiteUrl: string;
    dietOptions?: IDietOption[];
    reviews?: IReview[];
}

export interface IDietOption {
    id?: string;
    dietType: string;
}

export interface IReview {
    id?: string;
    title: string;
    description: string;
    gfScore: number;
    dfScore: number;
    mfScore: number;
    priceRating: number;
}
