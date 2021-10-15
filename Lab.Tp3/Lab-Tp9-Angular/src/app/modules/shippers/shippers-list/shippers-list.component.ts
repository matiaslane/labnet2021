import { Component, OnInit, TemplateRef } from '@angular/core';
import { Router } from '@angular/router';
import { NgxBootstrapConfirmService } from 'ngx-bootstrap-confirm';
import { ShippersService } from 'src/app/services/shippers.service';

@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.scss']
})
export class ShippersListComponent implements OnInit {

  public shippersList : Array<any> = [];

  constructor(
    private readonly router : Router,
    private shippersService : ShippersService,
    private ngxBootstrapConfirmService: NgxBootstrapConfirmService
  ) { }

  ngOnInit(): void {
    this.listarShippers();
  }

  openModal(id: number) {
    let options = {
      title: 'Desea borrar este registro?',
      confirmLabel: 'Confirmar',
      declineLabel: 'Cancel'
    }
    this.ngxBootstrapConfirmService.confirm(options).then((res: boolean) => {
      if (res) {
        this.borrarShipper(id);
      }
    });
  }

  listarShippers(): void {
    this.shippersService.obtenerShippers()
      .subscribe( s => {
        this.shippersList = s},
        (error) => alert(`No se puede borrar ${error}`)
      );
  }

  borrarShipper(id : number): void {
    this.shippersService.deleteShippers(id)
      .subscribe(() => {
        this.listarShippers();
      },
      error => alert(`No se puede borrar ${error}`)
    );
  }

  modificarShipper(id: number, name: string, phone: string) : void {
    this.router.navigate(['shippers/new'], { state: { shipperId: id, shipperName: name, shipperPhone: phone } });
  }
}
