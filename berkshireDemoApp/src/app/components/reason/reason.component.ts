import { Component, OnInit } from '@angular/core';
import { ReasonsServiceService } from 'src/app/services/reasons-service.service';
import { reasons_list, reasons_description } from 'src/app/models/reasonsModels';

@Component({
  selector: 'reason',
  templateUrl: './reason.component.html',
  styleUrls: ['./reason.component.css']
})
export class ReasonComponent implements OnInit {

  public reasonsList: reasons_list[];
  public selectedReason: number;
  public showReason: boolean;

  constructor(private reasonService: ReasonsServiceService) { }

  ngOnInit() {
    this.showReason = false;
    this.selectedReason = 0;
    this.getList();
  }

  getList(): void{
    this.reasonService.getReasonsList().subscribe(response=>{
      this.reasonsList = response;
    });
  }

  selection(i: number){
    this.showReason = false;
    this.selectedReason = i;
    setTimeout(() => {
      this.showReason = true;
    }, 100);
  }
}
