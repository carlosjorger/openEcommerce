import { Component } from '@angular/core';
import { Product } from './api/models';
import { ProductService } from './api/services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'OpenEcommerce-Frontend';
  public products:Product[]=[];
  public constructor(private api:ProductService){
    this.api.productGet$Json().subscribe(res=>{
      this.products=res;
    });
  }
}
