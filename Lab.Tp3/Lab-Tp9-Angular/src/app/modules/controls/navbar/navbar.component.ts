import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor(private router : Router) { }

  ngOnInit(): void {
  }

  public crearShipper() {
    this.router.navigate(['shippers/new']);
  }

  public listarShipper() {
    this.router.navigate(['shippers']);
  }

  public listarCategories() {
    this.router.navigate(['categories']);
  }
  
}
