import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductListComponent } from './product-list.component';
import { ProductService } from 'src/app/services/product.service';
import { Observable, of } from 'rxjs';
import { MatTableModule } from '@angular/material/table';
import { DebugElement } from '@angular/core';
import { By } from '@angular/platform-browser';

class MockProductService {
  getProducts() {
    return of([
      {
        id: 1,
        modelCode: 'SM-S8ABCD13',
        productName: 'Galaxy S3',
        serialNumber: 'SN00000001'
      },
      {
        id: 2,
        modelCode: 'SM-S8ABCD17',
        productName: 'Galaxy S7',
        serialNumber: 'SN00000002'
      },
      {
        id: 3,
        modelCode: 'SM-S8ABCD18',
        productName: 'Galaxy S8',
        serialNumber: 'SN00000003'
      },
      {
        id: 4,
        modelCode: 'SM-S8ABCD19',
        productName: 'Galaxy S9',
        serialNumber: 'SN00000004'
      },
      {
        id: 5,
        modelCode: 'SM-S8ABCD10',
        productName: 'Galaxy S10',
        serialNumber: 'SN00000005'
      }
    ]);
  }
}

describe('ProductListComponent', () => {
  let component: ProductListComponent;
  let fixture: ComponentFixture<ProductListComponent>;
  let el: DebugElement;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [MatTableModule],
      declarations: [ProductListComponent],
      providers: [{ provide: ProductService, useClass: MockProductService }]
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductListComponent);
    component = fixture.componentInstance;
    el = fixture.debugElement;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should show products', () => {
    var rows = el.queryAll(By.css('mat-row'));
    expect(rows.length).toEqual(5);
  });
});
