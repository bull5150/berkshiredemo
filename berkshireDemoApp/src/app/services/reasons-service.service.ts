import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { reasons_list, reasons_description } from '../models/reasonsModels';

@Injectable({
  providedIn: 'root'
})
export class ReasonsServiceService {

  constructor(private http: HttpClient) { }
  
  public getReasonsList(){
    return this.http.get<reasons_list[]>('api/reasons/list');
  }
  public getDescription(i: number){
    return this.http.get<reasons_description>('api/reasons/descriptions?id=' + i);
  }
}
