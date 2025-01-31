import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent implements OnInit {
  latestPosts: Feed[] = [];
  constructor(private http: HttpClient) { }

  ngOnInit() {
    //this.http.get<Feed[]>('http://localhost:63330/api/rssfeeds').subscribe(result => {
    //  this.latestPosts = result;
    //}, error => console.error(error));
  }

}

interface Feed {
  link: string;
  title: string;
  feedType: string;
  author: string;
  content: string;
  publishDate: string;
}
