import { IProduct } from "./Product";

export interface ICategory {

    name: string;
    imageUrl: string;
    id: number;
    isMultiSelectable : boolean;
    isColapsed: boolean;

    totalSelectedItems: number;

    products: IProduct[];

} 