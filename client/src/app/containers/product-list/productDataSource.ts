import { DataSource } from '@angular/cdk/collections';
import { ProductService } from 'src/app/services/product.service';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/product.model';

export class ProductDataSource extends DataSource<any> {
  constructor(private productService: ProductService) {
    super();
  }

  connect(): Observable<Product[]> {
    return this.productService.getProducts();
  }

  disconnect() {}
}
