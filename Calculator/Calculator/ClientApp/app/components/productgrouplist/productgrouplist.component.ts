import { Component, Inject } from "@angular/core";
import { IProductGroup } from "../models/Productgroup";
import { Http } from "@angular/http";

@Component({
    selector: 'productgroup-List',
    templateUrl: './productgrouplist.component.html'
})
    
export class ProductgroupListComponent {
    productgroups: IProductGroup[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Productgroups').subscribe(result => {
            this.productgroups = result.json() as IProductGroup[];
        }, error => console.error(error));
    }
}