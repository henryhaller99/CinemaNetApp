import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'CinemaApp';
  movies: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.http.get('https://localhost:5001/api/movies').subscribe(
      (response) => {
        this.movies = response;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
