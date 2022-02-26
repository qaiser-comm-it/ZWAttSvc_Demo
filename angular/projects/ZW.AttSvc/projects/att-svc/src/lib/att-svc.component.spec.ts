import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { AttSvcComponent } from './att-svc.component';

describe('AttSvcComponent', () => {
  let component: AttSvcComponent;
  let fixture: ComponentFixture<AttSvcComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ AttSvcComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AttSvcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
