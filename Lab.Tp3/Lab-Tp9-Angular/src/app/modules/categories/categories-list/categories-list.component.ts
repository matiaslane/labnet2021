import { Component, OnInit } from '@angular/core';
import { CategoriesService } from 'src/app/services/categories.service';

@Component({
  selector: 'app-Categories-list',
  templateUrl: './categories-list.component.html',
  styleUrls: ['./categories-list.component.scss']
})
export class CategoriesListComponent implements OnInit {

  public categoriesList : Array<any> = [];

  constructor(
    private categoriesService : CategoriesService
  ) { }
    
  ngOnInit(): void {
    this.listarCategorias();
  }

  listarCategorias(): void {
    this.categoriesService.obtenerCategorias().subscribe(
      c => { this.categoriesList = c },
      error => alert (error));
  }
}
