import { Component, Inject } from '@angular/core';
import { Http, Response } from '@angular/http';
import { IProductGroup } from '../models/Productgroup';
import { ISlectedProductEvent } from '../models/Productgroup';
import { ActivatedRoute } from "@angular/router";

@Component({
    selector: 'productgroup',
    templateUrl: './productgroup.component.html',
    styleUrls: ['./productgroup.component.css']
})
export class ProductgroupComponent {

    public productGroup: IProductGroup;
    public factualCost: number;
    public variableCost: number;
    public urlString: string;
    public selectedUrlString: string;

    constructor(private route: ActivatedRoute, http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.route.params.subscribe(params => {

            http.get(baseUrl + 'api/Productgroups/' + params.id).subscribe(result => {
                this.productGroup = result.json() as IProductGroup;
                console.log(result);
               
                this.urlString = baseUrl + 'home/' + params.id;
             
                var selectedHash = params.s;
                if (selectedHash !== undefined) {
                    this.setPredefinedSelectedProducts(selectedHash);
                }
                this.setSelectedProductParamUrl();
                this.calculateCost();
            },
                error => console.error(error));

        });
    }

    public onSelectProduct() {

        this.setSelectedProductParamUrl();
        this.calculateCost();
    }

    public setSelectedProductParamUrl() {

        var selectedStringWithCatValues: string = "";
        for (let i = 0; i < this.productGroup.categories.length; i++) {
            const category = this.productGroup.categories[i];

          var selectedValues: string = "";
          for (let i = 0; i < category.products.length; i++) {
                const product = category.products[i];

                if (product.isSelected) {
                    selectedValues = selectedValues + product.id + ',';
                }
            }
          selectedStringWithCatValues = selectedStringWithCatValues + 'c:' + category.id + '-' + selectedValues.substr(0, selectedValues.length -1);

        }
        this.selectedUrlString = this.urlString + "/" + selectedStringWithCatValues;
    }

    public setPredefinedSelectedProducts(param: string) {

        /////String c:<number>- is category sepeared with - that are all selected products separated with ,
        /////eg: c:1-1,2,3 category 1 has product 1,2,3 selected

        var slelectedCaregoriesAndProducts = param.substr(2, param.length-1).split('c:'); ////Split each category to array
        this.clearAllSelected();

        for (let i = 0; i < slelectedCaregoriesAndProducts.length; i++) {
            var groupedSelections = slelectedCaregoriesAndProducts[i].split('-'); 
            var selectedProducts = groupedSelections[1].split(',');

            for (let i = 0; i < this.productGroup.categories.length; i++) {
                var category = this.productGroup.categories[i];

                if (category.id.toString() === groupedSelections[0]) {

                    for (let i = 0; i < selectedProducts.length; i++) {
                        for (let x = 0; x < category.products.length; x++) {
                            var product = category.products[x];
                            var productId = selectedProducts[i];
                            if (product.id.toString() === productId) {
                                product.isSelected = true;
                            }
                        }
                    }
                }
            }
        }
    }

    public clearAllSelected() {

        for (let i = 0; i < this.productGroup.categories.length; i++) {
            var category = this.productGroup.categories[i];

            for (let i = 0; i < category.products.length; i++) {
                var product = category.products[i];
                product.isSelected = false;

            }
        }
    }

    public calculateCost() {

        var factualCost: number = 0.0;
        var variableCost: number = 0.0;

        for (let i = 0; i < this.productGroup.categories.length; i++) {
            var category = this.productGroup.categories[i];

            for (let i = 0; i < category.products.length; i++) {
                var product = category.products[i];

                if (product.isSelected) {
                    if (product.isFactualCost) {
                        factualCost = factualCost + product.price;
                    } else {
                        variableCost = variableCost + product.price;
                    }
                }
            }
        }

        this.factualCost = factualCost;
        this.variableCost = variableCost;
    }

}






