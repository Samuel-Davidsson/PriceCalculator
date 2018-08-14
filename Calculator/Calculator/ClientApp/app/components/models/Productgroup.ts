import { ICategory } from "./Category";

export interface IProductGroup {

    id: number;
    name: string;
    description: string;
    imageUrl: string;
    categories: ICategory[];
}

export interface ISlectedProductEvent {
    categoryId: number;
    productId: number;
}