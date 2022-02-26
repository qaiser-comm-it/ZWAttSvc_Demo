import { Component, OnInit } from '@angular/core';
import { AttSvcService } from '../services/att-svc.service';

@Component({
  selector: 'lib-att-svc',
  template: ` <p>att-svc works!</p> `,
  styles: [],
})
export class AttSvcComponent implements OnInit {
  constructor(private service: AttSvcService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
