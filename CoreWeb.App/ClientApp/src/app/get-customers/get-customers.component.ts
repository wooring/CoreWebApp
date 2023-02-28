import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-get-customers',
  templateUrl: './get-customers.component.html'
})
export class CustomersComponent {
  public customers: Customer[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Customer[]>(baseUrl + 'customer').subscribe(result => {
      this.customers = result;
    }, error => console.error(error));
  }
}

interface Customer {
  name: string;
  email: string;
  phone: string;
}
