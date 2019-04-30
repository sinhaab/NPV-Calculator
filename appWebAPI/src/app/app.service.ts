import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import NPVEntity from './npv.model';
@Injectable()
    export default class AppService {
 
  public API =  'http://localhost:5000';
  //public Test_API = `${this.API}/npv/test`;
  public npv_API = `${this.API}/npv/calculatenpv`;
  

  constructor(private http: HttpClient) {}

  //  getAll(): Observable<Array<string>> {
      
 //   return this.http.get<Array<string>>(this.Test_API);
//}

    save(npv: NPVEntity): Observable<number> {
   // let result: Observable<number>;
    return this.http.post<number>(this.npv_API, npv);

  }

}