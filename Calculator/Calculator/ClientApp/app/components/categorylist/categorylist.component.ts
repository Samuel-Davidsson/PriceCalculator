import { Component, Input, Output, EventEmitter } from "@angular/core";
import { ICategory } from "../models/Category";
import { IProduct } from "../models/Product";



@Component({
    selector: 'category-list',
    templateUrl: './categorylist.component.html',
    styleUrls: ['./product.component.css']
})

export class CategoryComponent {
    @Input() categories: ICategory[];
    @Input() product: IProduct;
    @Output() onSelectProduct: EventEmitter<object> = new EventEmitter();

    ngAfterContentInit() {
        this.setTotalSelectedItems();
    }

    setTotalSelectedItems() {

        if (this.categories === undefined) {
            return;
        }

        for (let i = 0; i < this.categories.length; i++) {
            const category = this.categories[i];

            category.totalSelectedItems = 0;

            for (let i = 0; i < category.products.length; i++) {
                const product = category.products[i];

                if (product.isSelected) {
                    category.totalSelectedItems = category.totalSelectedItems + 1;
                }
            }
        }
    }

    selectProduct(categoryId: number, productId: number) {

        for (let i = 0; i < this.categories.length; i++) {
            const category = this.categories[i];

            if (category.id === categoryId) {

                for (let i = 0; i < category.products.length; i++) {
                    const product = category.products[i];

                    if (product.id === productId) {
                        if (product.isSelected) {
                            product.isSelected = false;
                        } else {
                            product.isSelected = true;
                        }
                    } else {
                        if (!category.isMultiSelectable) {
                            product.isSelected = false;
                        }
                    }
                }
            }
        }
        this.setTotalSelectedItems();
        this.onSelectProduct.emit();
    }

    public onColapsed(category: ICategory) {
        category.isColapsed = !category.isColapsed;
    }
}