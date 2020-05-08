import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const sessionUrl = environment.apiUrl + 'session';
@Injectable()
export class Repository {
  constructor(private http: HttpClient) { }

  storeSessionData<T>(dataType: string, data: T) {
    return this.http.post(`${sessionUrl}/${dataType}`, data)
        .subscribe(response => { });
  }

  getSessionData<T>(dataType: string): Observable<T> {
      return this.http.get<T>(`${sessionUrl}/${dataType}`);
  }
}
