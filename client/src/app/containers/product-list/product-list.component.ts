import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/models/product.model';
import { ProductService } from 'src/app/services/product.service';
import { ProductDataSource } from './productDataSource';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {
  dataSource = new ProductDataSource(this.productService);
  displayedColumns = ['name', 'model', 'serial'];

  constructor(private productService: ProductService) {}

  ngOnInit() {}
}
