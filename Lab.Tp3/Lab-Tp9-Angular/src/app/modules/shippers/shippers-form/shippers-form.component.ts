import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ShippersModel } from 'src/app/modules/shippers/models/shippers-model';
import { ShippersService } from 'src/app/services/shippers.service';

@Component({
  selector: 'app-shippers-form',
  templateUrl: './shippers-form.component.html',
  styleUrls: ['./shippers-form.component.scss']
})
export class ShippersFormComponent implements OnInit {

  shippersForm!: FormGroup;
  public loading = false;

  private readonly shipperExistenteId : number | undefined;
  private readonly shipperExistenteName : string | undefined;
  private readonly shipperExistentePhone : string | undefined;
  
  constructor(
    private shippersService : ShippersService,
    private readonly fb: FormBuilder,
    private readonly router: Router
  ) { 
    this.shipperExistenteId  = this.router.getCurrentNavigation()?.extras.state?.shipperId;
    this.shipperExistenteName  = this.router.getCurrentNavigation()?.extras.state?.shipperName;
    this.shipperExistentePhone  = this.router.getCurrentNavigation()?.extras.state?.shipperPhone;
  }

  public get f() { return this.shippersForm.controls; }

  ngOnInit(): void {

    this.shippersForm = this.fb.group({

      nombre: [undefined,[Validators.required,
                          Validators.minLength(5),
                          Validators.maxLength(12)]],
      telefono :[undefined, [Validators.required]]
    });

    if(this.shipperExistenteId !== undefined){
          this.f.nombre.setValue(this.shipperExistenteName);
          this.f.telefono.setValue(this.shipperExistentePhone);
    }
  }

  getValue(value : string) {
    return this.shippersForm.get(value); 
  }

  onSubmit(): void {
    if(this.shipperExistenteId == undefined){
      var shipper = new ShippersModel();
      shipper.name = this.shippersForm.get('nombre')?.value;
      shipper.phone = this.shippersForm.get('telefono')?.value;
    
      this.shippersService.crearShippers(shipper).subscribe( s => 
        this.router.navigate(['/shippers']),
        error => alert (error))
    }

    if(this.shipperExistenteId !== undefined){
      var shipper = new ShippersModel();
      shipper.name = shipper.name = this.shippersForm.get('nombre')?.value;
      shipper.phone = this.shippersForm.get('telefono')?.value;

      this.shippersService.updateShippers(this.shipperExistenteId,shipper).subscribe( s =>
        this.router.navigate(['/shippers']),
        error => alert (error))
    }
  }
}
