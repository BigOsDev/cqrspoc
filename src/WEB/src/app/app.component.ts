import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {
  title = 'app';

  constructor(private http: HttpClient) {

  }

  columnDefs = [
      {headerName: 'Id', field: 'id', editable: true },
      {headerName: 'Title', field: 'title', editable: true },
      {headerName: 'Description', field: 'description', editable: true},
      {headerName: 'Added', field: 'added', editable: true},
      {headerName: 'Price', field: 'price', editable: true},
      {headerName: 'Rate', field: 'rate', editable: true},
      {headerName: 'Votes', field: 'votes', editable: true},
      {headerName: 'Restaurant Name', field: 'restaurantName', editable: true},
      {headerName: 'Another', field: 'another1', editable: true},
      {headerName: 'Another', field: 'another2', editable: true},
      {headerName: 'Another', field: 'another3', editable: true},
      {headerName: 'Another', field: 'another4', editable: true}
  ];

  rowData: any;
  //  [
  //     { make: 'Toyota', model: 'Celica', price: 35000, name: 'Olivia Brennan', country: 'Poland', another1: 'Sugoroku' , another2: 'Shogi' , another3: 'Checkers' , another4: 'Ghosts' },
  //     { make: 'Ford', model: 'Mondeo', price: 32000, name: 'Mia Corbin', country: 'Sweden', another1: 'Patolli' , another2: 'Shogi' , another3: 'Shogi' , another4: 'Camelot'  },
  //     { make: 'Porsche', model: 'Boxter', price: 8000, name: 'Isla Fletcher', country: 'France', another1: 'Shogi' , another2: 'Shogi' , another3: 'Camelot' , another4: 'Patolli'  } ,     
  //     { make: 'Toyota', model: 'Celica', price: 35000, name: 'Olivia Brennan', country: 'Poland', another1: 'Sugoroku' , another2: 'Shogi' , another3: 'Checkers' , another4: 'Ghosts' },
  //     { make: 'Checkers', model: 'Bul', price: 98280, name: 'Mia Corbin', country: 'Sweden', another1: 'Patolli' , another2: 'Shogi' , another3: 'Shogi' , another4: 'Camelot'  },
  //     { make: 'Tablut', model: 'Gipf', price: 12400, name: 'Isla Fletcher', country: 'France', another1: 'Shogi' , another2: 'Shogi' , another3: 'Camelot' , another4: 'Patolli'  },
  //     { make: 'Toyota', model: 'Wari', price: 92000, name: 'Olivia Brennan', country: 'Poland', another1: 'Sugoroku' , another2: 'Shogi' , another3: 'Checkers' , another4: 'Ghosts' },
  //     { make: 'Master Mind', model: 'PUNCT', price: 72000, name: 'Mia Corbin', country: 'Sweden', another1: 'Patolli' , another2: 'Shogi' , another3: 'Shogi' , another4: 'Camelot'  },
  //     { make: 'Kalah', model: 'Boxter', price: 49000, name: 'Isla Fletcher', country: 'France', another1: 'Shogi' , another2: 'Shogi' , another3: 'Camelot' , another4: 'Patolli'  } ,   
  //       { make: 'Toyota', model: 'Celica', price: 35000, name: 'Olivia Brennan', country: 'Poland', another1: 'Sugoroku' , another2: 'Shogi' , another3: 'Checkers' , another4: 'Ghosts' },
  //     { make: 'Ford', model: 'Mondeo', price: 67080, name: 'Mia Corbin', country: 'Sweden', another1: 'Patolli' , another2: 'Shogi' , another3: 'Shogi' , another4: 'Camelot'  },
  //     { make: 'Sugoroku', model: 'Boxter', price: 79400, name: 'Isla Fletcher', country: 'France', another1: 'Shogi' , another2: 'Shogi' , another3: 'Camelot' , another4: 'Patolli'  }
  // ];

  ngOnInit() {
    this.http.get('https://localhost:5001/weatherforecast').subscribe(data=> this.rowData =  (data as any).result);
  }

  onCellValueChanged(params) {
    console.log(params);
  }
  
}
